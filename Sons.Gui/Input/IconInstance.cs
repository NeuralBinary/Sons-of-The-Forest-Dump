using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Input
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[Serializable]
	internal class IconInstance
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public InputMapType Key
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			[CompilerGenerated]
			get
			{
				return InputMapType.KeyboardAndMouse;
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public GameObject Value
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		public InputIconProgress Progress
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public IconInstance()
		{
		}
	}
}
