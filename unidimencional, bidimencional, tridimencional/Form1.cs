namespace unidimencional__bidimencional__tridimencional
{
    public partial class Form1 : Form
    {
        // Arreglo unidimensional
        int[] Unidimentional = new int[3];
        int index = 0;

        // Arreglo bidimensional
        Bidimencional[,] Bidimentional = new Bidimencional[3, 3];
        int matriz = 0;

        // Arreglo tridimensional
        int[,,] Tridiementional = new int[3, 3, 3];
        int indextridimention = 0;
        public Form1()
        {
            InitializeComponent();



        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(NumericElectionArray.Value) == 1)
            {
                ListArray1.Clear();
                foreach (int item in Unidimentional)
                {
                    ListArray1.Items.Add(item.ToString());
                }

            }
            if (Convert.ToInt16(NumericElectionArray.Value) == 2)
            {
                // Mostrar el arreglo bidimensional
                ListArray1.Clear();
                for (int i = 0; i < Bidimentional.GetLength(0); i++)
                {
                    for (int j = 0; j < Bidimentional.GetLength(1); j++)
                    {
                        if (Bidimentional[i, j] != null)
                        {
                            ListArray1.Items.Add(Bidimentional[i, j].ToString());
                        }
                        else
                        {
                            ListArray1.Items.Add("null");
                        }
                    }
                }

            }
            if (Convert.ToInt16(NumericElectionArray.Value) == 3)
            {
                ListArray1.Clear();
                for (int x = 0; x < Tridiementional.GetLength(0); x++)
                {
                    for (int y = 0; y < Tridiementional.GetLength(1);y++)
                    {
                        for (int z = 0; z < Tridiementional.GetLength(2); z++)
                        {
                            if (Tridiementional[x, y, z] != null)
                            {
                                ListArray1.Items.Add(Tridiementional[x, y, z].ToString());
                            }
                            else
                            {
                                ListArray1.Items.Add("null");
                            }
                        }
                        
                    }
                }

            }


        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(NumericElectionArray.Value) == 1)
            {
                if (index == Unidimentional.Length)
                {
                    MessageBox.Show("The array is full");
                }
                try
                {
                    int numer = int.Parse(TextDataNum.Text);

                    Unidimentional[index++] = numer;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Convert.ToInt16(NumericElectionArray.Value) == 2)
            {
                if (matriz == Bidimentional.LongLength)
                {
                    MessageBox.Show("The array is full");
                }
                try
                {

                    int numer = int.Parse(TextDataNum.Text);
                    int numer2 = int.Parse(DataNum2.Text);

                    Bidimentional[matriz / 3, matriz % 3] = new Bidimencional(numer, numer2);
                    matriz++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (Convert.ToInt16(NumericElectionArray.Value) == 3)
            {
                if (indextridimention == Tridiementional.Length)
                {
                    MessageBox.Show("The array is full");
                }
                try
                {
                    int numer = int.Parse(TextDataNum.Text);
                    int numer2 = int.Parse(DataNum2.Text);
                    int numer3 = int.Parse(DataNum3.Text);

                    Tridiementional[indextridimention / 9, (indextridimention / 3) % 3, indextridimention % 3] = numer;
                    indextridimention++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NumericElectionArray_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
