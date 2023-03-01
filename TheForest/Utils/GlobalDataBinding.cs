using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003C1 RID: 961
	[Token(Token = "0x20003C1")]
	public class GlobalDataBinding : MonoBehaviour
	{
		// Token: 0x06001953 RID: 6483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001953")]
		[Address(RVA = "0x2CC7400", Offset = "0x2CC6400", VA = "0x182CC7400")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001954")]
		[Address(RVA = "0x2CC7190", Offset = "0x2CC6190", VA = "0x182CC7190")]
		public void SetIntData(int value)
		{
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001955")]
		[Address(RVA = "0x2CC70C0", Offset = "0x2CC60C0", VA = "0x182CC70C0")]
		public void SetFloatData(float value)
		{
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x2CC7330", Offset = "0x2CC6330", VA = "0x182CC7330")]
		public void SetStringData(string value)
		{
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x2CC7260", Offset = "0x2CC6260", VA = "0x182CC7260")]
		public void SetLongData(long value)
		{
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x2CC6F70", Offset = "0x2CC5F70", VA = "0x182CC6F70")]
		public void ClearIntData()
		{
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001959")]
		[Address(RVA = "0x2CC6F00", Offset = "0x2CC5F00", VA = "0x182CC6F00")]
		public void ClearFloatData()
		{
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195A")]
		[Address(RVA = "0x2CC7050", Offset = "0x2CC6050", VA = "0x182CC7050")]
		public void ClearStringData()
		{
		}

		// Token: 0x0600195B RID: 6491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195B")]
		[Address(RVA = "0x2CC6FE0", Offset = "0x2CC5FE0", VA = "0x182CC6FE0")]
		public void ClearLongData()
		{
		}

		// Token: 0x0600195C RID: 6492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195C")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public GlobalDataBinding()
		{
		}

		// Token: 0x040018C7 RID: 6343
		[Token(Token = "0x40018C7")]
		[FieldOffset(Offset = "0x20")]
		public string _dataName;

		// Token: 0x040018C8 RID: 6344
		[Token(Token = "0x40018C8")]
		[FieldOffset(Offset = "0x28")]
		public GlobalDataSaver.DataTypes _dataType;

		// Token: 0x040018C9 RID: 6345
		[Token(Token = "0x40018C9")]
		[FieldOffset(Offset = "0x30")]
		public string _message;
	}
}
