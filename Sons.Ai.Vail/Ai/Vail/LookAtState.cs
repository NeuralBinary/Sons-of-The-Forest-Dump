using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Serializable]
	internal class LookAtState
	{
		// Token: 0x0600042C RID: 1068 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x2B10B70", Offset = "0x2B0F170", VA = "0x182B10B70")]
		public float GetWeight(float distance, float distanceXZ)
		{
			return 0f;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x2B10C30", Offset = "0x2B0F230", VA = "0x182B10C30")]
		public bool Matches(State currentState)
		{
			return default(bool);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x2B10C90", Offset = "0x2B0F290", VA = "0x182B10C90")]
		private Color GetStateButtonColor()
		{
			return default(Color);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x2B10D20", Offset = "0x2B0F320", VA = "0x182B10D20")]
		private IEnumerable GetStateTreeView()
		{
			return null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x2B10D60", Offset = "0x2B0F360", VA = "0x182B10D60")]
		public LookAtState()
		{
		}

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private State _state;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LookAtRange _range;

		// Token: 0x04000357 RID: 855
		[Token(Token = "0x4000357")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minDistanceXZ;
	}
}
