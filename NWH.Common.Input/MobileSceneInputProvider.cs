using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Input
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class MobileSceneInputProvider : SceneInputProviderBase
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x26F3580", Offset = "0x26F1B80", VA = "0x1826F3580", Slot = "6")]
		public override bool ChangeCamera()
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x26F3660", Offset = "0x26F1C60", VA = "0x1826F3660", Slot = "12")]
		public override bool ChangeVehicle()
		{
			return default(bool);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "13")]
		public override Vector2 CharacterMovement()
		{
			return default(Vector2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "14")]
		public override bool ToggleGUI()
		{
			return default(bool);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "7")]
		public override Vector2 CameraRotation()
		{
			return default(Vector2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5BC460", Offset = "0x5BAA60", VA = "0x1805BC460", Slot = "8")]
		public override Vector2 CameraPanning()
		{
			return default(Vector2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
		public override bool CameraRotationModifier()
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "10")]
		public override bool CameraPanningModifier()
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "11")]
		public override float CameraZoom()
		{
			return 0f;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x26EE020", Offset = "0x26EC620", VA = "0x1826EE020")]
		public MobileSceneInputProvider()
		{
		}

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		public MobileInputButton changeCameraButton;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		public MobileInputButton changeVehicleButton;
	}
}
