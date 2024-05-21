char* findLatestTime(char* s) {
//    int minute = s[3];
//    printf("%d",minute);

    if(s[0]==63)
        if((s[1]<50)||(s[1]==63))
            s[0]=49;
        else
            s[0]=48;
    if(s[1]==63)
        if(s[0]==49)
            s[1]=49;
        else
            s[1]=57;
    if(s[3]==63)
        s[3]=53;
    if(s[4]==63)
        s[4]=57;
//    for(int x = 0; x < len; x++)
//    {
//        printf("%c %d\n",s[x], hourOne);
//    }
    return s;
}