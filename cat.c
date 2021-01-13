#include <stdio.h>
int main(int argc, char** argv)
{
    if (argc<2)
    {
        printf("Error: need more arguments!\nUsage: cat \"File Name\"");
        exit(0);
    }
    for (int i = 0; i < argc; ++i)
    {
        if (i>0)
        {
            char* ok;
            ok = "type ";
            char * command = (char *) malloc(1 + strlen(ok)+ strlen(argv[i]) );
            strcpy(command, ok);
            strcat(command, argv[i]);
            system(command);
        }
    }
    return 0;
}
