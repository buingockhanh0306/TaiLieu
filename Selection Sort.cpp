/*Giai bai toan sap xep bang phuong phap Selection Sort*/
#include <iostream>
using namespace std;
void xuat(int a[], int n)
	{
		int i;
		cout<<"\nDay da duoc sap xep la: ";
		for (i=0; i<=n-1; i++)
		cout<<a[i]<<"  ";
	}

int main()
{
	int n, i, j, x;
	cout<<"Day gom bao nhieu so: ";
	cin>>n;
	int a[n];
	for (i=0;i<=n-1;i++)
		{
			cout<<"\nNhap phan tu thu "<<i+1<<": ";
			cin>>a[i];
			
		};
	for (i=0; i<=n-1; i++)
	 	{
	 		for(j=i+1; j<=n-1; j++)
	 			{
	 				if(a[j]<a[i])
	 					{
	 						x=a[i];
							a[i]=a[j];
							a[j]=x;
						 };
				 };
		 };
	xuat(a, n);

		 return 0;
}
/*Bui Ngoc Khanh-1800587-K42L_CNTT*/
