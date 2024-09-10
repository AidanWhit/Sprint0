#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main (int argc, char**argv){
    char *str = malloc(sizeof(char) *3);
    memcpy(str, "abc", 3);
    printf("%s\n", str);
    free(str);
}