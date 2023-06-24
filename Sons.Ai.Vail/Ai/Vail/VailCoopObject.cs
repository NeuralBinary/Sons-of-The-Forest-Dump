using System;
using Bolt;
using Endnight.Physics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[AddComponentMenu("Sons/Weapon/VailCoopObject")]
	public class VailCoopObject : EntityEventListener<IRigidbodyState>, IKillBoxReceiver
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600047F")]
		[Address(RVA = "0xA9A080", Offset = "0xA98680", VA = "0x180A9A080", Slot = "323")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x2B17E30", Offset = "0x2B16430", VA = "0x182B17E30", Slot = "324")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x2B17E90", Offset = "0x2B16490", VA = "0x182B17E90", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x2B17FB0", Offset = "0x2B165B0", VA = "0x182B17FB0")]
		private void StartDestroyTimer()
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x2B18070", Offset = "0x2B16670", VA = "0x182B18070", Slot = "322")]
		private void HitKillBox()
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x2B18150", Offset = "0x2B16750", VA = "0x182B18150")]
		public VailCoopObject()
		{
		}

		// Token: 0x040003C0 RID: 960
		[Token(Token = "0x40003C0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lifeTimeSeconds;
	}
}
