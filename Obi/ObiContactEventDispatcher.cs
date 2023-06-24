using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Obi
{
	// Token: 0x020001C1 RID: 449
	[Token(Token = "0x20001C1")]
	[RequireComponent(typeof(ObiSolver))]
	public class ObiContactEventDispatcher : MonoBehaviour
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x00004AB4 File Offset: 0x00002CB4
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x27F6230", Offset = "0x27F4830", VA = "0x1827F6230")]
		private static int CompareByRef(ref Oni.Contact a, ref Oni.Contact b, ObiSolver solver)
		{
			return 0;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x27F6330", Offset = "0x27F4930", VA = "0x1827F6330")]
		private void Awake()
		{
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x27F6500", Offset = "0x27F4B00", VA = "0x1827F6500")]
		private void OnEnable()
		{
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x27F6590", Offset = "0x27F4B90", VA = "0x1827F6590")]
		private void OnDisable()
		{
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00004ACC File Offset: 0x00002CCC
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x27F6620", Offset = "0x27F4C20", VA = "0x1827F6620")]
		private int FilterOutDistantContacts(Oni.Contact[] data, int count)
		{
			return 0;
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00004AE4 File Offset: 0x00002CE4
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x27F68B0", Offset = "0x27F4EB0", VA = "0x1827F68B0")]
		private int RemoveDuplicates(Oni.Contact[] data, int count)
		{
			return 0;
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x27F6A50", Offset = "0x27F5050", VA = "0x1827F6A50")]
		private void InvokeCallbacks(Oni.Contact[] data, int count)
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x27F6EA0", Offset = "0x27F54A0", VA = "0x1827F6EA0")]
		private void Solver_OnCollision(object sender, ObiSolver.ObiCollisionEventArgs args)
		{
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x27F74D0", Offset = "0x27F5AD0", VA = "0x1827F74D0")]
		public ObiContactEventDispatcher()
		{
		}

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x20")]
		private ObiSolver solver;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x28")]
		private Oni.Contact[] prevData;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x30")]
		private int prevCount;

		// Token: 0x0400074D RID: 1869
		[Token(Token = "0x400074D")]
		[FieldOffset(Offset = "0x38")]
		private ObiContactEventDispatcher.ContactComparer comparer;

		// Token: 0x0400074E RID: 1870
		[Token(Token = "0x400074E")]
		[FieldOffset(Offset = "0x40")]
		public float distanceThreshold;

		// Token: 0x0400074F RID: 1871
		[Token(Token = "0x400074F")]
		[FieldOffset(Offset = "0x48")]
		public ObiContactEventDispatcher.ContactCallback onContactEnter;

		// Token: 0x04000750 RID: 1872
		[Token(Token = "0x4000750")]
		[FieldOffset(Offset = "0x50")]
		public ObiContactEventDispatcher.ContactCallback onContactStay;

		// Token: 0x04000751 RID: 1873
		[Token(Token = "0x4000751")]
		[FieldOffset(Offset = "0x58")]
		public ObiContactEventDispatcher.ContactCallback onContactExit;

		// Token: 0x020001C2 RID: 450
		[Token(Token = "0x20001C2")]
		private class ContactComparer : IComparer<Oni.Contact>
		{
			// Token: 0x060008B5 RID: 2229 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public ContactComparer(ObiSolver solver)
			{
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00004AFC File Offset: 0x00002CFC
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x27F76A0", Offset = "0x27F5CA0", VA = "0x1827F76A0", Slot = "4")]
			public int Compare(Oni.Contact x, Oni.Contact y)
			{
				return 0;
			}

			// Token: 0x04000752 RID: 1874
			[Token(Token = "0x4000752")]
			[FieldOffset(Offset = "0x10")]
			private ObiSolver solver;
		}

		// Token: 0x020001C3 RID: 451
		[Token(Token = "0x20001C3")]
		[Serializable]
		public class ContactCallback : UnityEvent<ObiSolver, Oni.Contact>
		{
			// Token: 0x060008B7 RID: 2231 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x27F76D0", Offset = "0x27F5CD0", VA = "0x1827F76D0")]
			public ContactCallback()
			{
			}
		}
	}
}
