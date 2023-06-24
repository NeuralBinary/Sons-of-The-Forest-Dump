using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	[CreateAssetMenu(fileName = "NewBallisticSettings", menuName = "Ballistics/Settings", order = 1)]
	public class BallisticSettings : ScriptableObject
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x90D5A0", Offset = "0x90BBA0", VA = "0x18090D5A0")]
		public BallisticSettings()
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x18")]
		public bool BulletDrop;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x19")]
		public bool BulletDrag;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x1A")]
		public bool BallisticMaterials;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x1C")]
		public float MaximumDeltaTime;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x20")]
		public float VisualToPhysicalSpeed;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x24")]
		public QueryTriggerInteraction TriggerInteraction;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 WindVelocity;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x34")]
		public float AirDensity;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x38")]
		public BallisticMaterial DefaultBallisticMaterial;
	}
}
