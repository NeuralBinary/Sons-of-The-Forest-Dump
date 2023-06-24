using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[ExecuteAlways]
	public class FpsController : ImmediateModeShapeDrawer
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A5A670", Offset = "0x2A58C70", VA = "0x182A5A670")]
		private void Awake()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A5A7A0", Offset = "0x2A58DA0", VA = "0x182A5A7A0", Slot = "4")]
		public override void DrawShapes(Camera cam)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A5AC90", Offset = "0x2A59290", VA = "0x182A5AC90")]
		private IEnumerator FixedSteps()
		{
			return null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A5AD20", Offset = "0x2A59320", VA = "0x182A5AD20")]
		public static void DrawRoundedArcOutline(Vector2 origin, float radius, float thickness, float outlineThickness, float angStart, float angEnd)
		{
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A5AFB0", Offset = "0x2A595B0", VA = "0x182A5AFB0")]
		public Vector2 GetShake(float speed, float amp)
		{
			return default(Vector2);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000020B4 File Offset: 0x000002B4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		private bool InputFocus
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2A5B110", Offset = "0x2A59710", VA = "0x182A5B110")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2A5B160", Offset = "0x2A59760", VA = "0x182A5B160")]
			set
			{
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A5B200", Offset = "0x2A59800", VA = "0x182A5B200")]
		private void FixedUpdateManual()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A5B630", Offset = "0x2A59C30", VA = "0x182A5B630")]
		private void Update()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A5BF10", Offset = "0x2A5A510", VA = "0x182A5BF10")]
		public FpsController()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A5C0F0", Offset = "0x2A5A6F0", VA = "0x182A5C0F0")]
		[CompilerGenerated]
		private void <Update>g__DoInput|30_0(KeyCode key, Vector2 dir)
		{
		}

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x28")]
		public Transform head;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		public Camera cam;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		public Crosshair crosshair;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x40")]
		public ChargeBar chargeBar;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x48")]
		public AmmoBar ammoBar;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x50")]
		public Compass compass;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x58")]
		public Transform crosshairTransform;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x60")]
		[Range(0.8f, 1f)]
		[Header("Player Movement")]
		public float smoof;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x64")]
		public float moveSpeed;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x68")]
		public float lookSensitivity;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x6C")]
		private float yaw;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x70")]
		private float pitch;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x74")]
		private Vector2 moveInput;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 moveVel;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x88")]
		[Range(0f, 3.1415927f)]
		[Header("Sidebar Style")]
		public float ammoBarAngularSpanRad;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x8C")]
		[Range(0f, 0.05f)]
		public float ammoBarOutlineThickness;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x90")]
		[Range(0f, 0.2f)]
		public float ammoBarThickness;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x94")]
		[Range(0f, 0.2f)]
		public float ammoBarRadius;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x98")]
		[Header("Animation")]
		[Range(0f, 0.3f)]
		public float fireSidebarRadiusPunchAmount;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0xA0")]
		public AnimationCurve shakeAnimX;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0xA8")]
		public AnimationCurve shakeAnimY;
	}
}
