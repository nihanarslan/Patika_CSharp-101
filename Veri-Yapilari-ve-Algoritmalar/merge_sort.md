# Proje 2

[16,21,11,8,12,22] -> Merge Sort

Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.

          [16,21,11,8,12,22]        //böl
      [16,21,11]      [8,12,22]     //böl
     [16,21] [11]    [8,12] [22]    //böl
    [16] [21] [11]  [8] [12] [22]   //birleştir
     [16,21] [11]    [8,12] [22]    //birleştir
      [11,16,21]      [8,12,22]     //birleştir
          [8,11,12,16,21,22]

Big-O gösterimini yazınız.

    Merge sort için BigO gösterimi O(nlogn)'dir.
