using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200018D RID: 397
	[Token(Token = "0x200018D")]
	public abstract class ObiNativeList<T> : IEnumerable<T>, IEnumerable, IDisposable, ISerializationCallbackReceiver where T : struct
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x000045EC File Offset: 0x000027EC
		// (set) Token: 0x0600075D RID: 1885 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000F9")]
		public int count
		{
			[Token(Token = "0x600075E")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600075D")]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00004604 File Offset: 0x00002804
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170000FA")]
		public int capacity
		{
			[Token(Token = "0x6000760")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600075F")]
			set
			{
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x170000FB")]
		public bool isCreated
		{
			[Token(Token = "0x6000761")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000FC RID: 252
		[Token(Token = "0x170000FC")]
		public T this[int index]
		{
			[Token(Token = "0x6000762")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000763")]
			set
			{
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000764")]
		public ObiNativeList(int capacity = 8, int alignment = 16)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000765")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000766")]
		protected void Dispose(bool disposing)
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000767")]
		public void Dispose()
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000768")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000769")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00004634 File Offset: 0x00002834
		[Token(Token = "0x600076A")]
		public NativeArray<U> AsNativeArray<U>() where U : struct
		{
			return default(NativeArray<U>);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000464C File Offset: 0x0000284C
		[Token(Token = "0x600076B")]
		public NativeArray<U> AsNativeArray<U>(int arrayLength) where U : struct
		{
			return default(NativeArray<U>);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600076C")]
		public ComputeBuffer AsComputeBuffer<U>() where U : struct
		{
			return null;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600076D")]
		protected void ChangeCapacity(int newCapacity, int byteAlignment = 16)
		{
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x600076E")]
		public bool Compare(ObiNativeList<T> other)
		{
			return default(bool);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600076F")]
		public void CopyFrom(ObiNativeList<T> source)
		{
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000770")]
		public void CopyFrom(ObiNativeList<T> source, int sourceIndex, int destIndex, int length)
		{
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000771")]
		public void CopyReplicate(T value, int destIndex, int length)
		{
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000772")]
		public void CopyTo(T[] dest, int sourceIndex, int length)
		{
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000773")]
		public void Clear()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000774")]
		public void Add(T item)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000775")]
		public void AddRange(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000776")]
		public void RemoveRange(int index, int count)
		{
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000777")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x6000778")]
		public bool ResizeUninitialized(int newCount)
		{
			return default(bool);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00004694 File Offset: 0x00002894
		[Token(Token = "0x6000779")]
		public bool ResizeInitialized(int newCount, [Optional] T value)
		{
			return default(bool);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x000046AC File Offset: 0x000028AC
		[Token(Token = "0x600077A")]
		public bool EnsureCapacity(int min)
		{
			return default(bool);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600077B")]
		public void WipeToZero()
		{
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600077C")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x600077D")]
		public unsafe void* AddressOfElement(int index)
		{
			return null;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x000046C4 File Offset: 0x000028C4
		[Token(Token = "0x600077E")]
		public IntPtr GetIntPtr()
		{
			return 0;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600077F")]
		public void Swap(int index1, int index2)
		{
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000780")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000781")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] serializedContents;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected unsafe void* m_AlignedPtr;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int m_Stride;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int m_Capacity;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int m_Count;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool m_AsNativeArray;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected ComputeBuffer m_ComputeBuffer;
	}
}
