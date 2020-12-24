#include <iostream>
using namespace std;
int partition(int A[], int p, int r)
{
	int tmp, i, x, j;
	x=A[r];
	i=p-1;
	for (j=p; j<=r; j++)
		{
			if(A[j]<x)
			{
				i++;
				tmp=A[i];
				A[i]=A[j];
				A[j]=tmp;
			}
		}
	i++;
	tmp=A[i];
	A[i]=A[r];
	A[r]=tmp;
	return i;
}

void qsort(int A[], int p, int r)
{
	int q;
	if(p<r)
	{
		q=partition(A, p, r);
		qsort(A, p, q-1);
		qsort(A, q+1, r);
		
	}
}
int main()
{
	int z, n;
	cout<<"\nDay do gom bao nhieu phan tu: ";
	cin>>n;
	int A[n];
	for (z=0; z<=n-1; z++)
		{cout<<"\nNhap phan tu thu "<<z+1<<": ";
		cin>>A[z];
		};
	qsort(A, 0, n-1);
	cout<<"\nDay da duoc sap xep la: ";
	for (z=0; z<=n-1; z++)
	{
		cout<<"  "<<A[z];
	}
	return 0;
};

