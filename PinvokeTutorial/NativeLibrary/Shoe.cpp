#include <string>
#include <iostream>
#include <comdef.h>
using namespace std;

struct Shoe
{
    int id;
    BSTR color;
    double size;
    BSTR brand;

    void buy()
    {
        cout << "Successfully purchased the ";
        wcout << color;
        wcout << " " << brand;
        cout << " shoe.";
    }
};

extern "C" __declspec(dllexport) void CreateShoe(Shoe* newShoe, double shoeSize)
{
    newShoe->id = 2;
    newShoe->size = shoeSize;
    newShoe->brand = SysAllocString(L"Adidas");
    newShoe->color = SysAllocString(L"Blue");
}

extern "C" __declspec(dllexport) void BuyShoe(Shoe shoe)
{
    shoe.buy();
}

