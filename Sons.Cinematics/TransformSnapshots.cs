using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Cinematics
{
	// Token: 0x02000013 RID: 19
	[Token(Token = "0x2000013")]
	public class TransformSnapshots : ScriptableObject
	{
		// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2D590A0", Offset = "0x2D576A0", VA = "0x182D590A0")]
		public void Add(TransformSnapshots.Snapshot recordSnapshot)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2D591D0", Offset = "0x2D577D0", VA = "0x182D591D0")]
		public void Clear()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2D59230", Offset = "0x2D57830", VA = "0x182D59230")]
		public List<TransformSnapshots.Snapshot> GetKeyIndexSnapshots(int keyIndex)
		{
			return null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2D593B0", Offset = "0x2D579B0", VA = "0x182D593B0")]
		public bool Apply(float frameTime, Transform target)
		{
			return default(bool);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2D59500", Offset = "0x2D57B00", VA = "0x182D59500")]
		private void Apply(float frameTime, Transform target, TransformSnapshots.Snapshot prev, TransformSnapshots.Snapshot next)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public TransformSnapshots()
		{
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<TransformSnapshots.Snapshot> _snapShots;

		// Token: 0x02000014 RID: 20
		[Token(Token = "0x2000014")]
		[Serializable]
		public class Snapshot
		{
			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600004E RID: 78 RVA: 0x00002208 File Offset: 0x00000408
			[Token(Token = "0x17000005")]
			public float TimeStamp
			{
				[Token(Token = "0x600004E")]
				[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00002220 File Offset: 0x00000420
			[Token(Token = "0x17000006")]
			public int KeyIndex
			{
				[Token(Token = "0x600004F")]
				[Address(RVA = "0x7849B0", Offset = "0x782FB0", VA = "0x1807849B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000050 RID: 80 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x2D59720", Offset = "0x2D57D20", VA = "0x182D59720")]
			public static TransformSnapshots.Snapshot Create(Transform target, float timeStamp, int keyIndex, int id, bool worldPos, bool worldRot)
			{
				return null;
			}

			// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x2D59990", Offset = "0x2D57F90", VA = "0x182D59990")]
			public void Apply(Transform transform)
			{
			}

			// Token: 0x06000052 RID: 82 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2D59B90", Offset = "0x2D58190", VA = "0x182D59B90")]
			public static TransformSnapshots.Snapshot Lerp(float frameTime, TransformSnapshots.Snapshot prev, TransformSnapshots.Snapshot next)
			{
				return null;
			}

			// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Snapshot()
			{
			}

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _timeStamp;

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private int _transformId;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private string _transformName;

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Quaternion _rotation;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector3 _position;

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private Vector3 _scale;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private bool _worldPos;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x49")]
			[SerializeField]
			private bool _worldRot;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x4C")]
			[SerializeField]
			private int _keyIndex;
		}
	}
}
