using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E4 RID: 1252
	[Token(Token = "0x20004E4")]
	public class DistanceActivationComponents : DistanceActivationBase
	{
		// Token: 0x060020E4 RID: 8420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020E4")]
		[Address(RVA = "0x331E560", Offset = "0x331CB60", VA = "0x18331E560", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E5")]
		[Address(RVA = "0x331E590", Offset = "0x331CB90", VA = "0x18331E590")]
		private void Start()
		{
		}

		// Token: 0x060020E6 RID: 8422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E6")]
		[Address(RVA = "0x331E5B0", Offset = "0x331CBB0", VA = "0x18331E5B0", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E7")]
		[Address(RVA = "0x331E5C0", Offset = "0x331CBC0", VA = "0x18331E5C0", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E8")]
		[Address(RVA = "0x331E5D0", Offset = "0x331CBD0", VA = "0x18331E5D0")]
		private void SetObjectsEnabled(bool isActive)
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020E9")]
		[Address(RVA = "0x331E6F0", Offset = "0x331CCF0", VA = "0x18331E6F0")]
		public DistanceActivationComponents()
		{
		}

		// Token: 0x04001E88 RID: 7816
		[Token(Token = "0x4001E88")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _startDisabled;

		// Token: 0x04001E89 RID: 7817
		[Token(Token = "0x4001E89")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private MonoBehaviour[] _components;

		// Token: 0x04001E8A RID: 7818
		[Token(Token = "0x4001E8A")]
		private const string TaskName = "DistanceActivationComponents";
	}
}
