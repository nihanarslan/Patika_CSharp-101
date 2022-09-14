# Proje 1

[22,27,16,2,18,6] -> Insertion Sort

1. Yukarı verilen dizinin sort türüne göre aşamalarını yazınız.

    [22,27,16,2,18,6] sayı dizisinin insertion sort türüne göre aşamaları aşağıdaki gibidir.
    - **İlk geçişte:** İlk sayı 22 kendi başına sıralıdır. Bir işlem yapılmaz. 
    *[22,27,16,2,18,6]*
    - **İkinci geçişte:** 27 ile 22 kıyaslanınca 27'nin büyük olduğu görülür. Bir işlem yapılmaz.
    *[22,27,16,2,18,6]*
    - **Üçüncü geçişte:** 16 ile bir önceki sayı olan 27 kıyaslanır. 16 küçük olduğu için 27 ile yer değiştirir.
    [22,16,27,2,18,6]
    Bu durumda iken 16 bir önceki sayı olan 22 ile kıyaslanır. 16 küçük olduğu için 22 ile 16 yer değiştirir.
    *[16,22,27,2,18,6]*
    - **Dördüncü geçişte:** Sıradaki sayımız olan 2 bir önceki sayı ile kıyaslanır. 2 sayısı 27'den küçük olduğu için 2 ile 27 yer değiştirir.
    [16,22,2,27,18,6]
    Bu durumda iken 2 sayısı bir önceki sayı ile kıyaslanır. 2 sayısı 22 sayısından küçük olduğu için 2 ile 27 yer değiştirir.
    [16,2,22,27,18,6]
    2 sayısı tekrar bir önceki sayı ile kıyaslanır. 2 sayısı 16'dan küçük olduğu için 2 ile 16 yer değiştirir.
    *[2,16,22,27,18,6]*
    - **Beşinci geçişte:** Sıradaki sayımız olan 18 daha önceki adımlarda olduğu gibi kendisinden önceki sayılar ile karşılaştırılır. Eğer kendinden önceki sayılardan küçük ise bu sayılarla yer değiştirir.
    [2,16,22,27,18,6] -> [2,16,22,18,27,6] -> *[2,16,18,22,27,6]*
    - **Altıncı geçişte:** Son sayımız olan 6 daha önceki adımlarda olduğu gibi kendisinden önceki sayılar ile karşılaştırılır. Eğer kendinden önceki sayılardan küçük ise bu sayılarla yer değiştirir.
    [2,16,18,22,27,6] -> [2,16,18,22,6,27] -> [2,16,18,6,22,27] -> [2,16,6,18,22,27] -> *[2,6,16,18,22,27]*

2. Big-O gösterimini yazınız.

    En kötü durumda bu dizi için adım sayısı 0+1+2+3+4+...+n-1 = n*(n-1)/2 olacaktır. Artış oranı az olan katsayılar elimine edilebileceğinden Big O gösterimi O(n^2) olacaktır.

3. Time Complexity: Average case: Aradığımız sayının ortada olması,Worst case: Aradığımız sayının sonda olması, Best case: Aradığımız sayının dizinin en başında olması.

    Time Complexity
    Avarage case: Aradığımız sayının ortada olması durumunda Time Complexity: n^2 olacaktır.
    Best Case:  Aradığımız sayının başta olması durumunda Time Complexity: n olacaktır. 

4. Dizi sıralandıktan sonra 18 sayısı hangi case kapsamına girer? Yazınız.

    Dizinin sıralanmış hali [2,6,16,18,22,27] olacağından 18 sayısı ortada kalacaktır. Bu durumda 18 sayısı Avarage case kapsamına girer.

[7,3,5,8,2,9,4,15,6] dizisinin Insertion Sort'a göre ilk 4 adımını yazınız.

    [3,7,5,8,2,9,4,15,6]
    [3,5,7,8,2,9,4,15,6]
    [3,5,7,2,8,9,4,15,6]
    [3,5,2,7,8,9,4,15,6]



