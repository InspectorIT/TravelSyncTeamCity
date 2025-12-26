import unittest
import fermat

class Tests(unittest.TestCase):
    def test_n_3(self):
        self.assertEqual(fermat.fermat_holds(3), True)
    def test_n_4():
        self.assertEqual(fermat.fermat_holds(4), True)
    def test_n_2():
        self.assertEqual(fermat.fermat_holds(2), False)

if __name__ == "__main__":
    unittest.main()
