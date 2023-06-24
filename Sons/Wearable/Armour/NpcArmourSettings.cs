using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005D1 RID: 1489
	[Token(Token = "0x20005D1")]
	[CreateAssetMenu(fileName = "NpcArmourSettings", menuName = "Sons/Ai/NpcArmourSettings", order = 0)]
	public class NpcArmourSettings : ScriptableObject
	{
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x1700052C")]
		public float BreakAmount
		{
			[Token(Token = "0x60026C4")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x1700052D")]
		public float AbsorptionAmount
		{
			[Token(Token = "0x60026C5")]
			[Address(RVA = "0x70B930", Offset = "0x709F30", VA = "0x18070B930")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x1700052E")]
		public AudioImpactMaterial ImpactAudioMaterial
		{
			[Token(Token = "0x60026C6")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return AudioImpactMaterial.None;
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C7")]
		[Address(RVA = "0x33B4B90", Offset = "0x33B3190", VA = "0x1833B4B90")]
		public NpcArmourSettings()
		{
		}

		// Token: 0x040022F4 RID: 8948
		[Token(Token = "0x40022F4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _breakAmount;

		// Token: 0x040022F5 RID: 8949
		[Token(Token = "0x40022F5")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _absorptionAmount;

		// Token: 0x040022F6 RID: 8950
		[Token(Token = "0x40022F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioImpactMaterial _impactAudioMaterial;
	}
}
