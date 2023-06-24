using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Rigidbody))]
	public class Perimeter : MonoBehaviour, IList<Target>, ICollection<Target>, IEnumerable<Target>, IEnumerable
	{
		// Token: 0x060001CA RID: 458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x28C7B10", Offset = "0x28C6110", VA = "0x1828C7B10")]
		private void Awake()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x28C7C40", Offset = "0x28C6240", VA = "0x1828C7C40")]
		private IEnumerator UpdateSort()
		{
			return null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x28C7CD0", Offset = "0x28C62D0", VA = "0x1828C7CD0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x28C7F20", Offset = "0x28C6520", VA = "0x1828C7F20")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x28C7FF0", Offset = "0x28C65F0", VA = "0x1828C7FF0", Slot = "11")]
		public void Add(Target target)
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x28C81D0", Offset = "0x28C67D0", VA = "0x1828C81D0")]
		public bool Remove(Transform xform)
		{
			return default(bool);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x28C8240", Offset = "0x28C6840", VA = "0x1828C8240")]
		public bool Remove(Targetable targetable)
		{
			return default(bool);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x28C8460", Offset = "0x28C6A60", VA = "0x1828C8460", Slot = "15")]
		public bool Remove(Target target)
		{
			return default(bool);
		}

		// Token: 0x17000051 RID: 81
		[Token(Token = "0x17000051")]
		public Target this[int index]
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x28C8730", Offset = "0x28C6D30", VA = "0x1828C8730", Slot = "4")]
			get
			{
				return default(Target);
			}
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x28C87D0", Offset = "0x28C6DD0", VA = "0x1828C87D0", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x28C8820", Offset = "0x28C6E20", VA = "0x1828C8820", Slot = "12")]
		public void Clear()
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x28C89E0", Offset = "0x28C6FE0", VA = "0x1828C89E0")]
		public bool Contains(Transform transform)
		{
			return default(bool);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x28C8AE0", Offset = "0x28C70E0", VA = "0x1828C8AE0", Slot = "13")]
		public bool Contains(Target target)
		{
			return default(bool);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x28C8BB0", Offset = "0x28C71B0", VA = "0x1828C8BB0", Slot = "16")]
		public IEnumerator<Target> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x28C8C40", Offset = "0x28C7240", VA = "0x1828C8C40", Slot = "17")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x28C8CD0", Offset = "0x28C72D0", VA = "0x1828C8CD0", Slot = "14")]
		public void CopyTo(Target[] array, int arrayIndex)
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x28C8D50", Offset = "0x28C7350", VA = "0x1828C8D50", Slot = "6")]
		public int IndexOf(Target item)
		{
			return 0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x28C8D90", Offset = "0x28C7390", VA = "0x1828C8D90", Slot = "7")]
		public void Insert(int index, Target item)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x28C8DD0", Offset = "0x28C73D0", VA = "0x1828C8DD0", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x17000052")]
		public bool IsReadOnly
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x28C8E10", Offset = "0x28C7410", VA = "0x1828C8E10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000053")]
		public int Count
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x28C8E50", Offset = "0x28C7450", VA = "0x1828C8E50", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x28C8E90", Offset = "0x28C7490", VA = "0x1828C8E90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x28C9440", Offset = "0x28C7A40", VA = "0x1828C9440")]
		private bool IsInLayerMask(GameObject obj)
		{
			return default(bool);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x28C94D0", Offset = "0x28C7AD0", VA = "0x1828C94D0")]
		public Perimeter()
		{
		}

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x20")]
		internal TargetTracker targetTracker;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x28")]
		internal bool dirty;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x30")]
		private TargetList targets;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x38")]
		private Transform xform;
	}
}
