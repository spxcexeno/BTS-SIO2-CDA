var cc = new CompteCourant(1000m, "FR001", "Alice");
cc.Crediter(200m);
cc.Debiter(500m);
cc.AfficherSolde(); // 700
