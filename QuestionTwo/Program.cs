// See https://aka.ms/new-console-template for more information
//sample array
int [] jumps = new int[] {1,1,0,-1};

int result = KangarooJumps(jumps);
if (result < jumps.Length)
{
    Console.WriteLine(-1);
}
else
{
    Console.WriteLine($"Jumps = {result}");
}

int KangarooJumps(int[] jumps)
{
    int kangarooJumpsIndex = 0;
    int kangarooJumps = 0;

    for (int i = 0; i < jumps.Length; i++)
    {
        kangarooJumpsIndex++;
        if ((jumps[i] + kangarooJumps) > jumps.Length - 1 || (jumps[i] + kangarooJumps) < 0)
        {
            break;
        }
        else
        {
            kangarooJumps += jumps[i];
        }
    }

    return kangarooJumpsIndex++;
}

