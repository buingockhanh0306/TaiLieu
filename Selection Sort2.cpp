#include <iostream>
using namespace std;
void xuat(int a[], int n)
	{
		int i;
		cout<<"\nDay da duoc sap xep la: ";
		for (i=0; i<=n-1; i++)
		cout<<a[i]<<"  ";
	}
void nhap(int a[], int n)
	{
		int i;
		for (i=0;i<=n-1;i++)
		{
			cout<<"\nNhap phan tu thu "<<i+1<<": ";
			cin>>a[i];
			
		}
	}
int sapxep(int a[], int n)
	{
		int i, j, x;
		for (i=0; i<=n-1; i++)
	 	{
	 		for(j=i+1; j<=n-1; j++)
	 			{
	 				if(a[j]<a[i])
	 					{
	 						x=a[i];
							a[i]=a[j];
							a[j]=x;
						 }
				 }
		 }
	}
int main()
{
   		int n, i, j, x;
   			cout<<"Day gom bao nhieu so: ";
			cin>>n;
			int a[n];
			nhap(a, n);
			sapxep(a, n);
			xuat(a, n);
			return 0;
	}
		 
