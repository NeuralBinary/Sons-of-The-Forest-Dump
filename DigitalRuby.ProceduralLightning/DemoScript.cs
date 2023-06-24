using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public class DemoScript : MonoBehaviour
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000025")]
		[Address(RVA = "0xA2BB10", Offset = "0xA2A110", VA = "0x180A2BB10")]
		private void UpdateThunder()
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000026")]
		[Address(RVA = "0xA2BF50", Offset = "0xA2A550", VA = "0x180A2BF50")]
		private void UpdateMovement()
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000027")]
		[Address(RVA = "0xA2C460", Offset = "0xA2AA60", VA = "0x180A2C460")]
		private void UpdateMouseLook()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xA2CBC0", Offset = "0xA2B1C0", VA = "0x180A2CBC0")]
		private void UpdateQuality()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000029")]
		[Address(RVA = "0xA2CDB0", Offset = "0xA2B3B0", VA = "0x180A2CDB0")]
		private void UpdateOther()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002A")]
		[Address(RVA = "0xA2CED0", Offset = "0xA2B4D0", VA = "0x180A2CED0")]
		private void OnGUI()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002B")]
		[Address(RVA = "0xA2D410", Offset = "0xA2BA10", VA = "0x180A2D410")]
		private void Update()
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002C")]
		[Address(RVA = "0xA2D550", Offset = "0xA2BB50", VA = "0x180A2D550")]
		private void Start()
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x600002D")]
		[Address(RVA = "0xA2D780", Offset = "0xA2BD80", VA = "0x180A2D780")]
		public static float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xA2D7C0", Offset = "0xA2BDC0", VA = "0x180A2D7C0")]
		public static void ReloadCurrentScene()
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600002F")]
		[Address(RVA = "0xA2D840", Offset = "0xA2BE40", VA = "0x180A2D840")]
		public DemoScript()
		{
		}

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x20")]
		public ThunderAndLightningScript ThunderAndLightningScript;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x28")]
		public LightningBoltScript LightningBoltScript;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x30")]
		public ParticleSystem CloudParticleSystem;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x38")]
		public float MoveSpeed;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x3C")]
		public bool EnableMouseLook;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		private const float fastCloudSpeed = 50f;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x40")]
		private float deltaTime;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x44")]
		private float fpsIncrement;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x48")]
		private string fpsText;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x50")]
		private DemoScript.RotationAxes axes;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x54")]
		private float sensitivityX;

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x58")]
		private float sensitivityY;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x5C")]
		private float minimumX;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x60")]
		private float maximumX;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x64")]
		private float minimumY;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x68")]
		private float maximumY;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x6C")]
		private float rotationX;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x70")]
		private float rotationY;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x74")]
		private Quaternion originalRotation;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x0")]
		private static readonly GUIStyle style;

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		private enum RotationAxes
		{
			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			MouseXAndY,
			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			MouseX,
			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			MouseY
		}
	}
}
