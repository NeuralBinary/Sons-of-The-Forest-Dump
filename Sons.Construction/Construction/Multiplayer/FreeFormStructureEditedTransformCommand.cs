using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction.Multiplayer
{
	// Token: 0x02000285 RID: 645
	[Token(Token = "0x2000285")]
	public class FreeFormStructureEditedTransformCommand : FreeFormStructureCommand
	{
		// Token: 0x060013B8 RID: 5048 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B8")]
		[Address(RVA = "0x2F5C100", Offset = "0x2F5A700", VA = "0x182F5C100")]
		public void Init(int dbVersion, int typeID, int instanceID, Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013B9")]
		[Address(RVA = "0x2F5C130", Offset = "0x2F5A730", VA = "0x182F5C130", Slot = "4")]
		public override void Execute(ConstructionManager manager)
		{
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BA")]
		[Address(RVA = "0x2F5C2B0", Offset = "0x2F5A8B0", VA = "0x182F5C2B0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060013BB RID: 5051 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60013BB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public FreeFormStructureEditedTransformCommand()
		{
		}

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x18")]
		private int _typeID;

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x1C")]
		private int _instanceID;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x20")]
		private Vector3 _position;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x2C")]
		private Quaternion _rotation;
	}
}
