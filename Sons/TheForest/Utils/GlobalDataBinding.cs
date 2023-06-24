using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public class GlobalDataBinding : MonoBehaviour
	{
		// Token: 0x0600198E RID: 6542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x3294AF0", Offset = "0x32930F0", VA = "0x183294AF0")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x3294B80", Offset = "0x3293180", VA = "0x183294B80")]
		public void SetIntData(int value)
		{
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x3294CC0", Offset = "0x32932C0", VA = "0x183294CC0")]
		public void SetFloatData(float value)
		{
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x3294E00", Offset = "0x3293400", VA = "0x183294E00")]
		public void SetStringData(string value)
		{
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x3294F40", Offset = "0x3293540", VA = "0x183294F40")]
		public void SetLongData(long value)
		{
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x3295080", Offset = "0x3293680", VA = "0x183295080")]
		public void ClearIntData()
		{
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001994")]
		[Address(RVA = "0x32950F0", Offset = "0x32936F0", VA = "0x1832950F0")]
		public void ClearFloatData()
		{
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x3295160", Offset = "0x3293760", VA = "0x183295160")]
		public void ClearStringData()
		{
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x32951D0", Offset = "0x32937D0", VA = "0x1832951D0")]
		public void ClearLongData()
		{
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public GlobalDataBinding()
		{
		}

		// Token: 0x040018E6 RID: 6374
		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x20")]
		public string _dataName;

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x28")]
		public GlobalDataSaver.DataTypes _dataType;

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x30")]
		public string _message;
	}
}
