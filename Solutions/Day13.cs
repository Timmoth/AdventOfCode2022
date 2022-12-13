using Xunit.Abstractions;

public static class Day13
{
    public static int ProcessPart1(string[] input)
    {
        var sum = 0;
        var pairs = 1;
        var inputIndex = 0;
        while (inputIndex < input.Length)
        {
            var lhs = Parse(input[inputIndex++]);
            var rhs = Parse(input[inputIndex++]);

            if (Compare(lhs, rhs) == -1)
            {
                sum += pairs;
            }

            inputIndex++; // Skip empty line
            pairs++;
        }

        return sum;
    }

    public static int ProcessPart2(string[] input)
    {
        var items = new List<Item>();
        var inputIndex = 0;

        // Parse input
        while (inputIndex < input.Length)
        {
            var inputLine = input[inputIndex++];
            if(inputLine.Length == 0)
            {
                continue;
            }

            items.Add(Parse(inputLine));
        }

        // Add divider packets
        var a = new ListItem()
        {
            Val = new List<Item>(){
                new IntItem()
                {
                    Val = 2
                }
            }
        };

        var b = new ListItem()
        {
            Val = new List<Item>(){
                new IntItem()
                {
                    Val = 6
                }
            }
        };

        items.Add(a);
        items.Add(b);

        // Sort list
        items.Sort(Compare);

        return (items.IndexOf(a) + 1) * (items.IndexOf(b) + 1);
    }

    public abstract class Item
    {
        public abstract override string ToString();
    }

    public class IntItem : Item
    {
        public int Val { get; set; }

        public override string ToString()
        {
            return Val.ToString();
        }
    }
    public class ListItem : Item
    {
        public List<Item> Val { get; set; }

        public override string ToString()
        {
            return $"[{string.Join(',', Val.Select(v => v.ToString()))}]";
        }
    }

    public static Item Parse(ReadOnlySpan<char> input)
    {
        var items = new List<Item>();

        var inputIndex = 0;
        var inputEndIndex = input.Length;
        while (inputIndex < inputEndIndex)
        {
            var c = input[inputIndex];
            if (c == '[')
            {
                // Parse list
                var listStringIndex = inputIndex;
                var listStringLength = 0;
                int listNesting = 1;
                inputIndex++;
                while (listNesting > 0)
                {
                    c = input[inputIndex++];
                    // Loop until we find the end of the list
                    if (c == '[')
                    {
                        listNesting++;
                    }else if(c == ']')
                    {
                        listNesting--;
                    }
                    listStringLength++;

                }

                // Recursivly parse the contents of the list and store as a list item
                items.Add(Parse(input.Slice(listStringIndex + 1, listStringLength - 1)));

                inputIndex++; // Ignore comma
            }
            else
            {
                //Parse int
                int intStringIndex = inputIndex;
                var intStringLength = 0;

                // Loop until we find the next comma
                while (inputIndex < inputEndIndex && char.IsDigit(input[inputIndex++]))
                {
                    intStringLength++;
                }

                if(intStringLength > 0)
                {
                    // Add parsed int item
                    items.Add(new IntItem()
                    {
                        Val = int.Parse(input.Slice(intStringIndex, intStringLength))
                    });
                }
            }

        }

        return new ListItem()
        {
            Val = items
        };
    }

    public static int Compare(Item lhs, Item rhs)
    {
        if (lhs == rhs)
        {
            // Both are the same
            return 0;
        }

        if(lhs is IntItem lIntItem && rhs is IntItem rIntItem)
        {
            if (lIntItem.Val == rIntItem.Val)
            {
                // Both are the same
                return 0;
            }
            if (lIntItem.Val < rIntItem.Val)
            {
                // lhs < rhs correct order
                return -1;
            }

            // lhs > rhs wrong order
            return 1;
        }

        if (lhs is not ListItem lListItem)
        {
            // Convert to ListItem
            lListItem = new ListItem()
            {
                Val = new List<Item> { lhs }
            };
        }

        if (rhs is not ListItem rListItem)
        {
            // Convert to ListItem
            rListItem = new ListItem()
            {
                Val = new List<Item> { rhs }
            };
        }

        var index = 0;
        while (index < lListItem.Val.Count())
        {
            if(index >= rListItem.Val.Count())
            {
                // RHS ran out of items first, wrong order
                return 1;
            }

            // Compare next item in list
            var comparison = Compare(lListItem.Val[index], rListItem.Val[index]);
            if (comparison == 0)
            {
                // both are equal keep checking
                index++;
                continue;
            }

            // We determined the order was either correct / incorrect
            return comparison;
        }

        if(lListItem.Val.Count() == rListItem.Val.Count())
        {
            // if we could not determine the order and both lists are the same length
            return 0;
        }

        // The lists are in the correct order
        return -1;
    }
}