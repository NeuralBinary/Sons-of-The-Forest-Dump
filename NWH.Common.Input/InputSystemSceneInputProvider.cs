using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.Common.Input
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public class InputSystemSceneInputProvider : SceneInputProviderBase
	{
		// Token: 0x06000015 RID: 21 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x26EE2A0", Offset = "0x26EC8A0", VA = "0x1826EE2A0", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021A0 File Offset: 0x000003A0
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x26EE6F0", Offset = "0x26ECCF0", VA = "0x1826EE6F0", Slot = "6")]
		public override bool ChangeCamera()
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021B8 File Offset: 0x000003B8
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26EE780", Offset = "0x26ECD80", VA = "0x1826EE780", Slot = "7")]
		public override Vector2 CameraRotation()
		{
			return default(Vector2);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000021D0 File Offset: 0x000003D0
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26EE830", Offset = "0x26ECE30", VA = "0x1826EE830", Slot = "8")]
		public override Vector2 CameraPanning()
		{
			return default(Vector2);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000021E8 File Offset: 0x000003E8
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26EE8E0", Offset = "0x26ECEE0", VA = "0x1826EE8E0", Slot = "9")]
		public override bool CameraRotationModifier()
		{
			return default(bool);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002200 File Offset: 0x00000400
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x26EE900", Offset = "0x26ECF00", VA = "0x1826EE900", Slot = "10")]
		public override bool CameraPanningModifier()
		{
			return default(bool);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002218 File Offset: 0x00000418
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x26EE920", Offset = "0x26ECF20", VA = "0x1826EE920", Slot = "11")]
		public override float CameraZoom()
		{
			return 0f;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002230 File Offset: 0x00000430
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x26EE9D0", Offset = "0x26ECFD0", VA = "0x1826EE9D0", Slot = "12")]
		public override bool ChangeVehicle()
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002248 File Offset: 0x00000448
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x26EEA60", Offset = "0x26ED060", VA = "0x1826EEA60", Slot = "13")]
		public override Vector2 CharacterMovement()
		{
			return default(Vector2);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002260 File Offset: 0x00000460
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x26EEB10", Offset = "0x26ED110", VA = "0x1826EEB10", Slot = "14")]
		public override bool ToggleGUI()
		{
			return default(bool);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x26EE020", Offset = "0x26EC620", VA = "0x1826EE020")]
		public InputSystemSceneInputProvider()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		public SceneInputActions sceneInputActions;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		private bool _rotationModifier;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x31")]
		private bool _panningModifier;
	}
}
