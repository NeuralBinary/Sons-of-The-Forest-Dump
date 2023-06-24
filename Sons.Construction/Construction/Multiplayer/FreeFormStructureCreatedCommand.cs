using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000282 RID: 642
	[Token(Token = "0x2000282")]
	public class FreeFormStructureCreatedCommand : FreeFormStructureCommand
	{
		// Token: 0x060013AC RID: 5036 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x2F5BA90", Offset = "0x2F5A090", VA = "0x182F5BA90")]
		public void Init(int dbVersion, int typeID, int instanceID, Vector3 position, Quaternion rotation, Structure alreadyCreated)
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x2F5BB10", Offset = "0x2F5A110", VA = "0x182F5BB10", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x2F5BE70", Offset = "0x2F5A470", VA = "0x182F5BE70", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureCreatedCommand()
		{
		}

		// Token: 0x04000989 RID: 2441
		[Token(Token = "0x4000989")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x0400098A RID: 2442
		[Token(Token = "0x400098A")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;

		// Token: 0x0400098B RID: 2443
		[Token(Token = "0x400098B")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 _position;

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion _rotation;

		// Token: 0x0400098D RID: 2445
		[Token(Token = "0x400098D")]
		[FieldOffset(Offset = "0x40")]
		private Structure _createdStructure;
	}
}
