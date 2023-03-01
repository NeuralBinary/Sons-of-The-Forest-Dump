using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Utils
{
	// Token: 0x020003B9 RID: 953
	[Token(Token = "0x20003B9")]
	public class FakeParent : MonoBehaviour
	{
		// Token: 0x060018F4 RID: 6388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x2CC4460", Offset = "0x2CC3460", VA = "0x182CC4460")]
		private void Awake()
		{
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x2CC4CB0", Offset = "0x2CC3CB0", VA = "0x182CC4CB0")]
		private void UpdateCleanupComponent()
		{
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F6")]
		[Address(RVA = "0x2CC46E0", Offset = "0x2CC36E0", VA = "0x182CC46E0")]
		public void Dispose()
		{
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018F7")]
		[Address(RVA = "0x2CC4670", Offset = "0x2CC3670", VA = "0x182CC4670")]
		private IEnumerator DelayedAwake()
		{
			return null;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F8")]
		[Address(RVA = "0x2CC4870", Offset = "0x2CC3870", VA = "0x182CC4870")]
		private void OnEnable()
		{
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F9")]
		[Address(RVA = "0x2CC4740", Offset = "0x2CC3740", VA = "0x182CC4740")]
		private void OnDisable()
		{
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x2CC4BB0", Offset = "0x2CC3BB0", VA = "0x182CC4BB0")]
		private IEnumerator UnParentRoutine()
		{
			return null;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x2CC4C20", Offset = "0x2CC3C20", VA = "0x182CC4C20")]
		public void UnParent()
		{
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x2CC4920", Offset = "0x2CC3920", VA = "0x182CC4920")]
		public void ReParent()
		{
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x2CC4B30", Offset = "0x2CC3B30", VA = "0x182CC4B30")]
		public void SetEulerRotation(Vector3 eulerRotation)
		{
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FE")]
		[Address(RVA = "0x24E4180", Offset = "0x24E3180", VA = "0x1824E4180")]
		public void SetPosition(Vector3 position)
		{
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018FF")]
		[Address(RVA = "0x5B2F00", Offset = "0x5B1F00", VA = "0x1805B2F00")]
		public void SetScale(Vector3 scale)
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x17000352")]
		public Vector3 RealPosition
		{
			[Token(Token = "0x6001900")]
			[Address(RVA = "0x2CC4EF0", Offset = "0x2CC3EF0", VA = "0x182CC4EF0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x17000353")]
		public Quaternion RealRotation
		{
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x2CC4FE0", Offset = "0x2CC3FE0", VA = "0x182CC4FE0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x17000354")]
		public Vector3 RealLocalPosition
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x24E4160", Offset = "0x24E3160", VA = "0x1824E4160")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001903 RID: 6403 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x17000355")]
		public Quaternion RealLocalRotation
		{
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x2680E10", Offset = "0x267FE10", VA = "0x182680E10")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001904")]
		[Address(RVA = "0x2CC4EE0", Offset = "0x2CC3EE0", VA = "0x182CC4EE0")]
		public FakeParent()
		{
		}

		// Token: 0x0400189F RID: 6303
		[Token(Token = "0x400189F")]
		[FieldOffset(Offset = "0x20")]
		public bool disableOnAwake;

		// Token: 0x040018A0 RID: 6304
		[Token(Token = "0x40018A0")]
		[FieldOffset(Offset = "0x21")]
		public bool ignoreWeaponPositionFix;

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x22")]
		public bool useScale;

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 _pos;

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x30")]
		private Vector3 _scale;

		// Token: 0x040018A4 RID: 6308
		[Token(Token = "0x40018A4")]
		[FieldOffset(Offset = "0x3C")]
		private Quaternion _rot;

		// Token: 0x040018A5 RID: 6309
		[Token(Token = "0x40018A5")]
		[FieldOffset(Offset = "0x4C")]
		private float timer;

		// Token: 0x040018A6 RID: 6310
		[Token(Token = "0x40018A6")]
		[FieldOffset(Offset = "0x50")]
		private Transform _target;
	}
}
