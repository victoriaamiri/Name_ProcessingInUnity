using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : ProcessingLite.GP21
{
    void Start()
    {
        Background(230, 120, 60);

        //V
        Line(0.5f, 7, 2, 3);
        Line(3.5f, 7, 2, 3);

        //I
        Line(4, 7, 4, 3);

        //C
        Line(5, 7, 5, 3);
        Line(5, 6.95f, 6.5f, 6.95f);
        Line(5, 3.05f, 6.5f, 3.05f);

        //T
        Line(8, 7, 8, 3);
        Line(7, 6.95f, 9, 6.95f);

        //O
        Line(9.7f, 7, 9.7f, 3);
        Line(9.7f, 6.95f, 11.5f, 6.95f);
        Line(9.7f, 3.05f, 11.5f, 3.05f);
        Line(11.5f, 7, 11.5f, 3);

        //R
        Line(12.5f, 7, 12.5f, 3);
        Line(12.5f, 6.95f, 14.2F, 6.95f);
        Line(12.5f, 5.1f, 14.2F, 5.1f);
        Line(14.2f, 7, 14.2f, 5.05f);
        Line(13.7f, 5.05f, 13.7f, 3);

        //I
        Line(15.2f, 7, 15.2f, 3);

        //A
        Line(16.5f, 7, 16.5f, 3);
        Line(16.5f, 6.95f, 18.25f, 6.95f);
        Line(16.5f, 5.1f, 18.25f, 5.1f);
        Line(18.3f, 7, 18.3f, 3);

    }
}

