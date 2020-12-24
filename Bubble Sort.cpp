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
	int n, i, j, tg;
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
		for(j=n-1; j>i; j--)
			{
				if (a[j]<a[j-1])
					{
					tg=a[j];
					a[j]=a[j-1];
					a[j-1]=tg;
					};
			};
		};
	xuat(a, n);
	return 0;
}
