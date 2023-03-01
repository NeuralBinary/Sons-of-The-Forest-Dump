using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	public class TimedStippling_Distance : MonoBehaviour
	{
		// Token: 0x06001A56 RID: 6742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A56")]
		[Address(RVA = "0x2CEE330", Offset = "0x2CED330", VA = "0x182CEE330")]
		private void Awake()
		{
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A57")]
		[Address(RVA = "0x2CEE610", Offset = "0x2CED610", VA = "0x182CEE610")]
		private void Update()
		{
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A58")]
		[Address(RVA = "0x2CEE4F0", Offset = "0x2CED4F0", VA = "0x182CEE4F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A59")]
		[Address(RVA = "0x2CEE500", Offset = "0x2CED500", VA = "0x182CEE500")]
		private void OnDisable()
		{
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5A")]
		[Address(RVA = "0x2CEE4F0", Offset = "0x2CED4F0", VA = "0x182CEE4F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5B")]
		[Address(RVA = "0x2CEE6F0", Offset = "0x2CED6F0", VA = "0x182CEE6F0")]
		private void VisibilityCheck()
		{
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5C")]
		[Address(RVA = "0x2CEE510", Offset = "0x2CED510", VA = "0x182CEE510")]
		private void SetStipplingAlpha(float alpha)
		{
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5D")]
		[Address(RVA = "0x2CEE450", Offset = "0x2CED450", VA = "0x182CEE450")]
		private void BeginStipplingIn()
		{
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5E")]
		[Address(RVA = "0x2CEE4B0", Offset = "0x2CED4B0", VA = "0x182CEE4B0")]
		private void BeginStipplingOut()
		{
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A5F")]
		[Address(RVA = "0x2CEE990", Offset = "0x2CED990", VA = "0x182CEE990")]
		private void WSRegister()
		{
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A60")]
		[Address(RVA = "0x2CEEA50", Offset = "0x2CEDA50", VA = "0x182CEEA50")]
		private void WSUnregister()
		{
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A61")]
		[Address(RVA = "0x2CEEAD0", Offset = "0x2CEDAD0", VA = "0x182CEEAD0")]
		public TimedStippling_Distance()
		{
		}

		// Token: 0x04001981 RID: 6529
		[Token(Token = "0x4001981")]
		[FieldOffset(Offset = "0x20")]
		public Renderer _renderer;

		// Token: 0x04001982 RID: 6530
		[Token(Token = "0x4001982")]
		[FieldOffset(Offset = "0x28")]
		public float _stippleOutDistance;

		// Token: 0x04001983 RID: 6531
		[Token(Token = "0x4001983")]
		[FieldOffset(Offset = "0x2C")]
		public float _stippleInDistance;

		// Token: 0x04001984 RID: 6532
		[Token(Token = "0x4001984")]
		[FieldOffset(Offset = "0x30")]
		private bool _isVisible;

		// Token: 0x04001985 RID: 6533
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x31")]
		private bool _stipplingIn;

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x34")]
		private float _alpha;

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x38")]
		private MaterialPropertyBlock _block;

		// Token: 0x04001988 RID: 6536
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x40")]
		private int _wsToken;
	}
}
