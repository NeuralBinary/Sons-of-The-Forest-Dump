using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player
{
	// Token: 0x0200045D RID: 1117
	[Token(Token = "0x200045D")]
	public class PlayerFollow : MonoBehaviour
	{
		// Token: 0x06001C54 RID: 7252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C54")]
		[Address(RVA = "0x2CEC6F0", Offset = "0x2CEB6F0", VA = "0x182CEC6F0")]
		private void Awake()
		{
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C55")]
		[Address(RVA = "0x2CFD310", Offset = "0x2CFC310", VA = "0x182CFD310")]
		private void OnEnable()
		{
		}

		// Token: 0x06001C56 RID: 7254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C56")]
		[Address(RVA = "0x2CFD300", Offset = "0x2CFC300", VA = "0x182CFD300")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C57")]
		[Address(RVA = "0x2CFD320", Offset = "0x2CFC320", VA = "0x182CFD320")]
		private void UpdatePosition()
		{
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C58")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public PlayerFollow()
		{
		}

		// Token: 0x04001B02 RID: 6914
		[Token(Token = "0x4001B02")]
		[FieldOffset(Offset = "0x20")]
		public Vector3 _forwardOffset;

		// Token: 0x04001B03 RID: 6915
		[Token(Token = "0x4001B03")]
		[FieldOffset(Offset = "0x2C")]
		public bool _matchRotation;

		// Token: 0x04001B04 RID: 6916
		[Token(Token = "0x4001B04")]
		[FieldOffset(Offset = "0x2D")]
		public bool _useVrCamera;

		// Token: 0x04001B05 RID: 6917
		[Token(Token = "0x4001B05")]
		[FieldOffset(Offset = "0x2E")]
		public bool _useVrWatch;

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x2F")]
		public bool _onEnable;
	}
}
