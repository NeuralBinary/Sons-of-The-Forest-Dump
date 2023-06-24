using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[AddComponentMenu("Sons/Stimuli/Light Stimuli")]
	public class LightStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000D66 RID: 3430 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D66")]
		[Address(RVA = "0x2BA3300", Offset = "0x2BA1900", VA = "0x182BA3300")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x6000D67")]
		[Address(RVA = "0x22F41B0", Offset = "0x22F27B0", VA = "0x1822F41B0")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x6000D68")]
		[Address(RVA = "0x2BA3330", Offset = "0x2BA1930", VA = "0x182BA3330")]
		private bool IsInCone(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x6000D69")]
		[Address(RVA = "0x2BA3510", Offset = "0x2BA1B10", VA = "0x182BA3510", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6A")]
		[Address(RVA = "0x2BA3830", Offset = "0x2BA1E30", VA = "0x182BA3830", Slot = "24")]
		protected override void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D6B")]
		[Address(RVA = "0x2BA3F50", Offset = "0x2BA2550", VA = "0x182BA3F50")]
		public LightStimuli()
		{
		}

		// Token: 0x040008AA RID: 2218
		[Token(Token = "0x40008AA")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _isCone;

		// Token: 0x040008AB RID: 2219
		[Token(Token = "0x40008AB")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _coneAngle;

		// Token: 0x040008AC RID: 2220
		[Token(Token = "0x40008AC")]
		[FieldOffset(Offset = "0xB0")]
		[FormerlySerializedAs("_coneDistance")]
		[SerializeField]
		private float _distance;
	}
}
