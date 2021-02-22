#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
    if (argc<2)
    {
        printf("Error: need more arguments!\nUsage: rm \"File Name\"");
        exit(0);
    }
    for (int i = 0; i < argc; ++i)
    {
        if (i>0)
        {
            remove(argv[i]);
        }
    }
    return 0;
}
