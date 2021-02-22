#include <stdio.h>

int main(int argc, char** argv)
{
    if (argc<2)
    {
        printf("Error: need more arguments!\nUsage: touch \"File Name\"");
    }
    else{
        for (int i = 0; i < argc; ++i)
        {
            if (i>0)
            {
                FILE *fp;
                fp=fopen(argv[i],"w");
                fclose(fp);
            }
        }
    }
    return 0;
}
