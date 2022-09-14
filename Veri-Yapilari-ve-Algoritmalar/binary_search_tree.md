# Proje 

[7, 5, 1, 8, 3, 6, 0, 9, 4, 2] dizisinin Binary-Search-Tree aşamalarını yazınız.

- Dizinin ilk elemanı olan 7'den başlayarak ve 7'nin root node olduğunu düşünerek en başa yerleştiririz.

|   Seviye  | |     | |
|   ---     |-|  -  |-|
|     0     | |**7**| |

- Dizinin ikinci elemanının bulunduğu node root node'a bağlı olmalıdır. Ve kurala göre 7'den büyükse sağ tarafa, 7'den küçükse sol tarafa eklenmelidir. İkinci eleman olan 5, 7'den küçük olduğu için sol tarafa ekliyoruz.

|   Seviye  |     | | | |
|   ---     |-    |-|-|-|
|     0     |     | |7| |
|           |     |/| | |
|     1     |**5**| | | |

- Dizinin üçüncü elemanı olan 1, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda 1. seviyede bulunan node'a da bakılır. Sıradaki sayı bir üstteki node'dan büyükse sağ tarafa küçükse sol tarafa eklenir. 

|   Seviye  |     | | | | | |
|   ---     |-    |-|-|-|-|-|
|     0     |     | | | |7| |
|           |     | | |/| | |
|     1     |     | |5| | | |
|           |     |/| | | | |
|     2     |**1**| | | | | |

- Dizinin dördüncü elemanı olan 8, 7'den büyük olduğu için sağ tarafa eklenecektir. 

|   Seviye  | | | | | |  |     | |
|   ---     |-|-|-|-|-|- |   - |-|
|     0     | | | | |7|  |     | |
|           | | | |/| |\ |     | |
|     1     | | |5| | |  |**8**| |
|           | |/| | | |  |     | |
|     2     |1| | | | |  |     | |

- Dizinin beşinci elemanı olan 3, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda önce solda 1. seviyede bulunan node'a da bakılır. 3 sayısı 5'ten küçük olduğu için sol tarafa gidilecektir. Fakat solda 2. seviyede 1 sayısının bulunduğu node vardır. Bu durumda 3 sayısı ile 1 sayısı karşılaştırılır. 3 sayısı büyük olduğu için sağ tarafta olacaktır.

|   Seviye  | | | |  |     | | |  | | |
|   ---     |-|-|-|- |-    |-|-|- |-|-|
|     0     | | | |  |     | |7|  | | |
|           | | | |  |     |/| |\ | | |
|     1     | | | |  |5    | | |  |8| |
|           | | | |/ |     | | |  | | |
|     2     | | |1|  |     | | |  | | | 
|           | | | |\ |     | | |  | | |
|     3     | | | |  |**3**| | |  | | |

- Dizinin altıncı elemanı olan 6, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda önce solda 1. seviyede bulunan node'a da bakılır. 6 sayısı 5'ten büyük olduğu için sağ tarafa gidilecektir. 

|   Seviye  | | | |  | |  |     |  | | | 
|   ---     |-|-|-|- |-|- |-    |- |-|-| 
|     0     | | | |  | |  |7    |  | | | 
|           | | | |  | |/ |     |\ | | |
|     1     | | | |  |5|  |     |  |8| |
|           | | | |/ | |\ |     |  | | |
|     2     | | |1|  | |  |**6**|  | | | 
|           | | | |\ | |  |     |  | | |
|     3     | | | |  |3|  |     |  | | |

- Dizinin yedinci elemanı olan 0, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda alttaki nodelara da bakılır ve 0 en küçük sayı olduğu için en sola yerleştirilir.

|   Seviye  |     | | |  | |  | |  | | |
|   ---     |-    |-|-|- |-|- |-|- |-|-|
|     0     |     | | |  | |  |7|  | | |
|           |     | | |  | |/ | |\ | | | 
|     1     |     | | |  |5|  | |  |8| | 
|           |     | | |/ | |\ | |  | | | 
|     2     |     | |1|  | |  |6|  | | | 
|           |     |/| |\ | |  | |  | | | 
|     3     |**0**| | |  |3|  | |  | | | 

- Dizinin sekizinci elemanı olan 9, 7'den büyük olduğu için sağ tarafa eklenecektir. Sağ tarafa 8'in bulunduğu node olduğu için 9 sayısı 8 ile karşılaştırılır ve 9 daha büyük olduğu için 8'in sağ tarafına yazılır. 

|   Seviye  | | | |  | |  | |  | |  |     |
|   ---     |-|-|-|- |-|- |-|- |-|- |-    |
|     0     | | | |  | |  |7|  | |  |     |
|           | | | |  | |/ | |\ | |  |     |
|     1     | | | |  |5|  | |  |8|  |     | 
|           | | | |/ | |\ | |  | |\ |     |  
|     2     | | |1|  | |  |6|  | |  |**9**|
|           | |/| |\ | |  | |  | |  |     |
|     3     |0| | |  |3|  | |  | |  |     |

- Dizinin dokuzuncu elemanı olan 4, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda önce solda 1. seviyede bulunan node'a da bakılır. 4 sayısı 5'ten küçük olduğu için sol tarafa gidilecektir. Fakat solda 2. seviyede 1 sayısının bulunduğu node vardır. Bu durumda 4 sayısı ile 1 sayısı karşılaştırılır. 4 sayısı büyük olduğu için sağ tarafta olacaktır. Fakat bir alttaki seviyede bu bölümde 3 sayısı bulunmaktadır. 4 sayısı 3 sayısı ile karşılaştırılır ve 4 daha büyük olduğu için sağa yazılır. 

|   Seviye  | | | |  | |  |     |  | |  | |
|   ---     |-|-|-|- |-|- |-    |- |-|- |-|
|     0     | | | |  | |  |7    |  | |  | |
|           | | | |  | |/ |     |\ | |  | |
|     1     | | | |  |5|  |     |  |8|  | | 
|           | | | |/ | |\ |     |  | |\ | |  
|     2     | | |1|  | |  |6    |  | |  |9|
|           | |/| |\ | |  |     |  | |  | |
|     3     |0| | |  |3|  |     |  | |  | |
|           | | | |  | |\ |     |  | |  | |
|     4     | | | |  | |  |**4**|  | |  | |

- Dizinin son elemanı olan 2, 7'den küçük olduğu için sol tarafa eklenecektir. Bu durumda önce solda 1. seviyede bulunan node'a da bakılır. 2 sayısı 5'ten küçük olduğu için sol tarafa gidilecektir. Fakat solda 2. seviyede 1 sayısının bulunduğu node vardır. Bu durumda 2 sayısı ile 1 sayısı karşılaştırılır. 2 sayısı büyük olduğu için sağ tarafta olacaktır. Fakat bir alttaki seviyede bu bölümde 3 sayısı bulunmaktadır. 2 sayısı 3 sayısı ile karşılaştırılır ve 2 daha küçük olduğu için sola yazılır. 

|   Seviye  | | |     |  | |  | |  | |  | |
|   ---     |-|-|-    |- |-|- |-|- |-|- |-|
|     0     | | |     |  | |  |7|  | |  | |
|           | | |     |  | |/ | |\ | |  | |
|     1     | | |     |  |5|  | |  |8|  | | 
|           | | |     |/ | |\ | |  | |\ | |  
|     2     | | |1    |  | |  |6|  | |  |9|
|           | |/|     |\ | |  | |  | |  | |
|     3     |0| |     |  |3|  | |  | |  | |
|           | | |     |/ | |\ | |  | |  | |
|     4     | | |**2**|  | |  |4|  | |  | |