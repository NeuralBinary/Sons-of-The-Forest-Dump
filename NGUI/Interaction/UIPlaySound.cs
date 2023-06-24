using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Interaction
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[AddComponentMenu("NGUI/Interaction/Play Sound")]
	public class UIPlaySound : MonoBehaviour
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x17000154")]
		private bool canPlay
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x26C6040", Offset = "0x26C4640", VA = "0x1826C6040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x26C6180", Offset = "0x26C4780", VA = "0x1826C6180")]
		private void OnEnable()
		{
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x26C6210", Offset = "0x26C4810", VA = "0x1826C6210")]
		private void OnDisable()
		{
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x26C62A0", Offset = "0x26C48A0", VA = "0x1826C62A0")]
		private void OnHover(bool isOver)
		{
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x26C6360", Offset = "0x26C4960", VA = "0x1826C6360")]
		private void OnPress(bool isPressed)
		{
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x26C6420", Offset = "0x26C4A20", VA = "0x1826C6420")]
		private void OnClick()
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x26C64C0", Offset = "0x26C4AC0", VA = "0x1826C64C0")]
		private void OnSelect(bool isSelected)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x26C65E0", Offset = "0x26C4BE0", VA = "0x1826C65E0")]
		public void Play()
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x26C6660", Offset = "0x26C4C60", VA = "0x1826C6660")]
		public UIPlaySound()
		{
		}

		// Token: 0x04000503 RID: 1283
		[Token(Token = "0x4000503")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip audioClip;

		// Token: 0x04000504 RID: 1284
		[Token(Token = "0x4000504")]
		[FieldOffset(Offset = "0x28")]
		public UIPlaySound.Trigger trigger;

		// Token: 0x04000505 RID: 1285
		[Token(Token = "0x4000505")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float volume;

		// Token: 0x04000506 RID: 1286
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 2f)]
		public float pitch;

		// Token: 0x04000507 RID: 1287
		[Token(Token = "0x4000507")]
		[FieldOffset(Offset = "0x34")]
		private bool mIsOver;

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		public enum Trigger
		{
			// Token: 0x04000509 RID: 1289
			[Token(Token = "0x4000509")]
			OnClick,
			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x400050A")]
			OnMouseOver,
			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			OnMouseOut,
			// Token: 0x0400050C RID: 1292
			[Token(Token = "0x400050C")]
			OnPress,
			// Token: 0x0400050D RID: 1293
			[Token(Token = "0x400050D")]
			OnRelease,
			// Token: 0x0400050E RID: 1294
			[Token(Token = "0x400050E")]
			Custom,
			// Token: 0x0400050F RID: 1295
			[Token(Token = "0x400050F")]
			OnEnable,
			// Token: 0x04000510 RID: 1296
			[Token(Token = "0x4000510")]
			OnDisable
		}
	}
}
