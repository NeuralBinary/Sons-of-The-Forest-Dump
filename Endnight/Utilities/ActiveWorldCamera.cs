using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class ActiveWorldCamera : MonoBehaviour
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000098 RID: 152 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000006")]
		public Camera Camera
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x6000099")]
		[Address(RVA = "0xA6A480", Offset = "0xA68A80", VA = "0x180A6A480")]
		public bool HasCameraComponent()
		{
			return default(bool);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x600009A")]
		[Address(RVA = "0xA6A540", Offset = "0xA68B40", VA = "0x180A6A540")]
		private bool MissingCameraComponent()
		{
			return default(bool);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x600009B")]
		[Address(RVA = "0xA6A560", Offset = "0xA68B60", VA = "0x180A6A560")]
		private Color GetGuiColor()
		{
			return default(Color);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xA6A5A0", Offset = "0xA68BA0", VA = "0x180A6A5A0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0xA6A5B0", Offset = "0xA68BB0", VA = "0x180A6A5B0")]
		private void ValidateCamera()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xA6A6E0", Offset = "0xA68CE0", VA = "0x180A6A6E0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xA6A720", Offset = "0xA68D20", VA = "0x180A6A720")]
		private void OnDisable()
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x7951A0", Offset = "0x7937A0", VA = "0x1807951A0")]
		public ActiveWorldCamera()
		{
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _automatic;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _camera;
	}
}
