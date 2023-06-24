using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging.TerrainDig
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	public class EnableDigNodesOverTime : MonoBehaviour
	{
		// Token: 0x06000183 RID: 387 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2FB3A80", Offset = "0x2FB2080", VA = "0x182FB3A80")]
		private void OnValidate()
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2FB3BE0", Offset = "0x2FB21E0", VA = "0x182FB3BE0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2FB3CA0", Offset = "0x2FB22A0", VA = "0x182FB3CA0")]
		private void Update()
		{
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2FB3E50", Offset = "0x2FB2450", VA = "0x182FB3E50")]
		public EnableDigNodesOverTime()
		{
		}

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<TerrainDigNode> _nodes;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _randomDelay;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _delayPerNode;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x30")]
		private int _currentIndex;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x34")]
		private float _startTime;
	}
}
