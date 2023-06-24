using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation.Mae
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[Serializable]
	public class ApplyImpact : ActionTemplate
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2D1D120", Offset = "0x2D1B720", VA = "0x182D1D120", Slot = "5")]
		public override Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2D1D140", Offset = "0x2D1B740", VA = "0x182D1D140", Slot = "11")]
		internal override bool Start()
		{
			return default(bool);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
		public ApplyImpact()
		{
		}

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _overrideData;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _direction;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _impactType;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _subImpactType;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _location;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _force;
	}
}
