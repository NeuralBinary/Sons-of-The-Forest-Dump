using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public class CameraController : MonoBehaviour
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000004")]
		public float x
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x6124A0", Offset = "0x610AA0", VA = "0x1806124A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x6124B0", Offset = "0x610AB0", VA = "0x1806124B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public float y
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0000215C File Offset: 0x0000035C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public float distanceTarget
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x23BB730", Offset = "0x23B9D30", VA = "0x1823BB730")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x28E2200", Offset = "0x28E0800", VA = "0x1828E2200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x28E2210", Offset = "0x28E0810", VA = "0x1828E2210")]
		public void SetAngles(Quaternion rotation)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28E2250", Offset = "0x28E0850", VA = "0x1828E2250")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x28E2260", Offset = "0x28E0860", VA = "0x1828E2260", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x28E2590", Offset = "0x28E0B90", VA = "0x1828E2590", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x28E2600", Offset = "0x28E0C00", VA = "0x1828E2600", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x28E26D0", Offset = "0x28E0CD0", VA = "0x1828E26D0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x28E2770", Offset = "0x28E0D70", VA = "0x1828E2770")]
		public void UpdateInput()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x28E2AC0", Offset = "0x28E10C0", VA = "0x1828E2AC0")]
		public void UpdateTransform()
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x28E2B20", Offset = "0x28E1120", VA = "0x1828E2B20")]
		public void UpdateTransform(float deltaTime)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002174 File Offset: 0x00000374
		[Token(Token = "0x17000007")]
		private float zoomAdd
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x28E3580", Offset = "0x28E1B80", VA = "0x1828E3580")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000218C File Offset: 0x0000038C
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x28E3630", Offset = "0x28E1C30", VA = "0x1828E3630")]
		private float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x28E3670", Offset = "0x28E1C70", VA = "0x1828E3670")]
		public CameraController()
		{
		}

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x20")]
		public Transform target;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x28")]
		public Transform rotationSpace;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x30")]
		public CameraController.UpdateMode updateMode;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x34")]
		public bool lockCursor;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x35")]
		[Header("Position")]
		public bool smoothFollow;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 offset;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x44")]
		public float followSpeed;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x48")]
		[Header("Rotation")]
		public float rotationSensitivity;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x4C")]
		public float yMinLimit;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x50")]
		public float yMaxLimit;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x54")]
		public bool rotateAlways;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x55")]
		public bool rotateOnLeftButton;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x56")]
		public bool rotateOnRightButton;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x57")]
		public bool rotateOnMiddleButton;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x58")]
		[Header("Distance")]
		public float distance;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x5C")]
		public float minDistance;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x60")]
		public float maxDistance;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x64")]
		public float zoomSpeed;

		// Token: 0x04000067 RID: 103
		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x68")]
		public float zoomSensitivity;

		// Token: 0x04000068 RID: 104
		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x6C")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		// Token: 0x04000069 RID: 105
		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x70")]
		public float blockingRadius;

		// Token: 0x0400006A RID: 106
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x74")]
		public float blockingSmoothTime;

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float blockedOffset;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 targetDistance;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 position;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0xA0")]
		private Quaternion rotation;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0xB0")]
		private Vector3 smoothPosition;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0xC0")]
		private Camera cam;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xC8")]
		private bool fixedFrame;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0xCC")]
		private float fixedDeltaTime;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0xD0")]
		private Quaternion r;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xE0")]
		private Vector3 lastUp;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xEC")]
		private float blockedDistance;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xF0")]
		private float blockedDistanceV;

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		[Serializable]
		public enum UpdateMode
		{
			// Token: 0x0400007B RID: 123
			[Token(Token = "0x400007B")]
			Update,
			// Token: 0x0400007C RID: 124
			[Token(Token = "0x400007C")]
			FixedUpdate,
			// Token: 0x0400007D RID: 125
			[Token(Token = "0x400007D")]
			LateUpdate,
			// Token: 0x0400007E RID: 126
			[Token(Token = "0x400007E")]
			FixedLateUpdate
		}
	}
}
