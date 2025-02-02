#include <bits/stdc++.h>
using namespace std;
#define rep(i, n) for (int i = 0; i < (int)(n); i++)
int main()
{
    vector<int> A(5);
    rep(i, 5)
    {
        cin >> A.at(i);
    }
    bool ok = false;
    rep(i, A.size() - 1)
    {
        if (A.at(i) == A.at(i + 1))
        {
            ok = true;
        }
    }
    if (ok)
        cout << "YES" << endl;
    else
        cout << "NO" << endl;
    return 0;
}
