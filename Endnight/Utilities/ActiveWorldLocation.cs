using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Animations;

namespace Endnight.Utilities
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	[AddComponentMenu("Endnight/Utilities/ActiveWorldLocation")]
	public class ActiveWorldLocation : MonoBehaviour
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000007")]
		public static Camera Camera
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xA6A7F0", Offset = "0xA68DF0", VA = "0x180A6A7F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xA6A830", Offset = "0xA68E30", VA = "0x180A6A830")]
		private Camera GetActiveCamera()
		{
			return null;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xA6ABA0", Offset = "0xA691A0", VA = "0x180A6ABA0")]
		public static void RegisterCamera(Camera camera)
		{
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xA6ADD0", Offset = "0xA693D0", VA = "0x180A6ADD0")]
		public static void UnregisterCamera(Camera camera)
		{
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000008")]
		public static Transform Transform
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xA6B040", Offset = "0xA69640", VA = "0x180A6B040")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xA6B0B0", Offset = "0xA696B0", VA = "0x180A6B0B0")]
		public static bool TryGetTransform(out Transform result)
		{
			return default(bool);
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x17000009")]
		public static WorldAreaTypeTracker WorldAreaTypeTracker
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xA6B2B0", Offset = "0xA698B0", VA = "0x180A6B2B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x1700000A")]
		public static Vector3 Position
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xA6B2D0", Offset = "0xA698D0", VA = "0x180A6B2D0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x6D1610", Offset = "0x6CFC10", VA = "0x1806D1610")]
		private void Update()
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xA6B3D0", Offset = "0xA699D0", VA = "0x180A6B3D0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xA6B3E0", Offset = "0xA699E0", VA = "0x180A6B3E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xA6B3F0", Offset = "0xA699F0", VA = "0x180A6B3F0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xA6B430", Offset = "0xA69A30", VA = "0x180A6B430")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xA6B600", Offset = "0xA69C00", VA = "0x180A6B600")]
		public static bool HasInstance()
		{
			return default(bool);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xA6B6E0", Offset = "0xA69CE0", VA = "0x180A6B6E0")]
		private static ActiveWorldLocation Instance()
		{
			return null;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xA6BBE0", Offset = "0xA6A1E0", VA = "0x180A6BBE0")]
		public static void SetTarget(Transform target)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xA6C100", Offset = "0xA6A700", VA = "0x180A6C100")]
		public static void RemoveTarget(Transform target)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xA6C610", Offset = "0xA6AC10", VA = "0x180A6C610")]
		public ActiveWorldLocation()
		{
		}

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x20")]
		private List<Camera> _cameras;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x28")]
		private Camera _activeCameraCached;

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x30")]
		private int _activeCameraCacheFrame;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x0")]
		private static ActiveWorldLocation _instance;

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x8")]
		private static bool _isInitialized;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x34")]
		private bool _isActiveAndEnabled;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x38")]
		private ParentConstraint _parentConstraint;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _position;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x50")]
		private WorldAreaTypeTracker _worldAreaTypeTracker;
	}
}
