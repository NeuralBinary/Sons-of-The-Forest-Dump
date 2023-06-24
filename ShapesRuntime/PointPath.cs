using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Shapes
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public class PointPath<T> : DisposableMesh
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0000455C File Offset: 0x0000275C
		[Token(Token = "0x170001A7")]
		public int Count
		{
			[Token(Token = "0x6000B14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001A8")]
		public T LastPoint
		{
			[Token(Token = "0x6000B15")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B16")]
		protected void OnSetFirstDataPoint()
		{
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B17")]
		public void ClearAllPoints()
		{
		}

		// Token: 0x170001A9 RID: 425
		[Token(Token = "0x170001A9")]
		public T this[int i]
		{
			[Token(Token = "0x6000B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B19")]
			set
			{
			}
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1A")]
		public void SetPoint(int index, T point)
		{
		}

		// Token: 0x06000B1B RID: 2843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1B")]
		public void AddPoint(T p)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1C")]
		public void AddPoints(params T[] pts)
		{
		}

		// Token: 0x06000B1D RID: 2845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1D")]
		public void AddPoints(IEnumerable<T> ptsToAdd)
		{
		}

		// Token: 0x06000B1E RID: 2846 RVA: 0x00004574 File Offset: 0x00002774
		[Token(Token = "0x6000B1E")]
		protected bool CheckCanAddContinuePoint([CallerMemberName] [Optional] string callerName)
		{
			return default(bool);
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B1F")]
		public PointPath()
		{
		}

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected List<T> path;
	}
}
