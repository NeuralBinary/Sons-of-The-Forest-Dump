using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	[CreateAssetMenu(fileName = "NpcArmourSettings", menuName = "Sons/Ai/NpcArmourSettings", order = 0)]
	public class NpcArmourSettings : ScriptableObject
	{
		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x060025C1 RID: 9665 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x17000518")]
		public float BreakAmount
		{
			[Token(Token = "0x60025C1")]
			[Address(RVA = "0x8CDC30", Offset = "0x8CCC30", VA = "0x1808CDC30")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x17000519")]
		public float AbsorptionAmount
		{
			[Token(Token = "0x60025C2")]
			[Address(RVA = "0x661930", Offset = "0x660930", VA = "0x180661930")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025C3")]
		[Address(RVA = "0x2DA6770", Offset = "0x2DA5770", VA = "0x182DA6770")]
		public NpcArmourSettings()
		{
		}

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _breakAmount;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _absorptionAmount;
	}
}
