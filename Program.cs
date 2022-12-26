// Decompiled with JetBrains decompiler
// Type: StickersASCO.Program
// Assembly: StickersASCO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84161D57-7025-41DC-978A-9B3AAFCE6EC5
// Assembly location: C:\Users\profi\Desktop\StickersASCO.exe

using System;
using System.Windows.Forms;

namespace StickersASCO
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
