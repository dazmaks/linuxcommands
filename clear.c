#include <stdio.h>
#include <stdlib.h>

int  main(void)
{
    #ifdef _WIN32
    system("cls");
	//add some other OSes here if needed
	#else
    #error "OS not supported."
    //you can also throw an exception indicating the function can't be used
	#endif
}