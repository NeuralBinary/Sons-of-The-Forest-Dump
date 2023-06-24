using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	public interface IMeshBuilder
	{
		// Token: 0x060014EB RID: 5355
		[Token(Token = "0x60014EB")]
		int AppendNewMesh(bool bHaveVtxNormals, bool bHaveVtxColors, bool bHaveVtxUVs, bool bHaveFaceGroups);

		// Token: 0x060014EC RID: 5356
		[Token(Token = "0x60014EC")]
		int AppendNewMesh(DMesh3 existingMesh);

		// Token: 0x060014ED RID: 5357
		[Token(Token = "0x60014ED")]
		void SetActiveMesh(int id);

		// Token: 0x060014EE RID: 5358
		[Token(Token = "0x60014EE")]
		int AppendVertex(double x, double y, double z);

		// Token: 0x060014EF RID: 5359
		[Token(Token = "0x60014EF")]
		int AppendVertex(NewVertexInfo info);

		// Token: 0x060014F0 RID: 5360
		[Token(Token = "0x60014F0")]
		int AppendTriangle(int i, int j, int k);

		// Token: 0x060014F1 RID: 5361
		[Token(Token = "0x60014F1")]
		int AppendTriangle(int i, int j, int k, int g);

		// Token: 0x060014F2 RID: 5362
		[Token(Token = "0x60014F2")]
		int BuildMaterial(GenericMaterial m);

		// Token: 0x060014F3 RID: 5363
		[Token(Token = "0x60014F3")]
		void AssignMaterial(int materialID, int meshID);

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060014F4 RID: 5364
		[Token(Token = "0x17000350")]
		bool SupportsMetaData { [Token(Token = "0x60014F4")] get; }

		// Token: 0x060014F5 RID: 5365
		[Token(Token = "0x60014F5")]
		void AppendMetaData(string identifier, object data);
	}
}
