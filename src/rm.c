#include <stdio.h>

int main(int argc, char** argv)
{
    if (argc<2)
    {
        printf("Error: need more arguments!\nUsage: rm \"File Name\"");
    }else{
        for (int i = 0; i < argc; ++i)
        {
            if (i>0)
            {
                remove(argv[i]);
            }
        }
    }
    return 0;
}
