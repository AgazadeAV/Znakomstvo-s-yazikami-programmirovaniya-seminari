// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца.


int[] FindMinIndexes(int[,] array){
    int min = array[0,0];
    int[] indexes = {0, 0};

    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            if(array[i,j] < min){
                min = array[i,j];
                indexes[0] = i;
                indexes[1] = j;
            } 
        } 
    } 

    return indexes; 
} 
 
int[,] DeleteRowColumn(int[,] array, int[] indexes){ 
    int[,] ints = new int [array.GetLength(0) - 1, array.GetLength(1) - 1]; 
 
    for (int i = 0; i < ints.GetLength(0); i++){ 
        for (int j = 0; j < ints.GetLength(1); j++){ 
            if (i >= indexes[0] && j < indexes[1]){ 
                ints[i,j] = array[i+1,j]; 
            } else if (j >= indexes[1] && i < indexes[0]){ 
                ints[i,j] = array[i,j+1]; 
            } else if (i >= indexes[0] && j >= indexes[1]){ 
                ints[i,j] = array[i+1,j+1]; 
            }else { 
                ints[i,j] = array[i, j]; 
            } 
             
        } 
    } 
 
    return ints; 
}