#include <stdio.h>
int main(int argc, char** argv)
{
    if (argc<2)
    {
        printf("Error: need more arguments!\nUsage: cat \"File Name\"");
    }
    else{
        for (int i = 0; i < argc; ++i)
        {
            if (i>0)
            {
                FILE* file = fopen(argv[i], "r"); /* should check the result */
                char line[256];

                while (fgets(line, sizeof(line), file)) {
                /* note that fgets don't strip the terminating \n, checking its
                presence would allow to handle lines longer that sizeof(line) */
                printf("%s", line);
                }
                /* may check feof here to make a difference between eof and io failure -- network
                timeout for instance */

                fclose(file);
            }
        }
    }
    return 0;
}
