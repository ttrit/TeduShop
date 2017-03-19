using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Data.Infrastructure
{
  public class Dispoable : IDisposable
  {
    private bool IsDisposed;

    ~Dispoable()
    {
      Dispose(false);
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    private void Dispose(bool disposing)
    {
      if (!IsDisposed && disposing)
      {
        DisposeCore();
      }

      IsDisposed = true;
    }

    // Override this to dispose custom objects
    protected virtual void DisposeCore()
    {

    }
  }
}
