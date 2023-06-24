using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Input
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	public abstract class SceneInputProviderBase : InputProvider
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "6")]
		public virtual bool ChangeCamera()
		{
			return default(bool);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "7")]
		public virtual Vector2 CameraRotation()
		{
			return default(Vector2);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "8")]
		public virtual Vector2 CameraPanning()
		{
			return default(Vector2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x26F3740", Offset = "0x26F1D40", VA = "0x1826F3740", Slot = "9")]
		public virtual bool CameraRotationModifier()
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x26F3750", Offset = "0x26F1D50", VA = "0x1826F3750", Slot = "10")]
		public virtual bool CameraPanningModifier()
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "11")]
		public virtual float CameraZoom()
		{
			return 0f;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "12")]
		public virtual bool ChangeVehicle()
		{
			return default(bool);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "13")]
		public virtual Vector2 CharacterMovement()
		{
			return default(Vector2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
		public virtual bool ToggleGUI()
		{
			return default(bool);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x26F3760", Offset = "0x26F1D60", VA = "0x1826F3760")]
		protected SceneInputProviderBase()
		{
		}

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("    If true a button press will be required to unlock camera rotation.")]
		public bool requireCameraRotationModifier;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x21")]
		[Tooltip("    If true a button press will be required to unlock camera panning.")]
		public bool requireCameraPanningModifier;
	}
}
