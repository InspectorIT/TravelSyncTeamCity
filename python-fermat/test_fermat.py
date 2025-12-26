from fermat import fermat_holds

def test_n_3():
    assert fermat_holds(3)

def test_n_4():
    assert fermat_holds(4)

def test_n_2():
    assert not fermat_holds(2)
