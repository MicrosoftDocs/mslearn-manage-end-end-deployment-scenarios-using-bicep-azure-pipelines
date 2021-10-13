IF NOT EXISTS (SELECT Id FROM [Toys] WHERE Id=1)
BEGIN
  INSERT INTO [Toys] (Id, Name, Description, Price, ImageId) VALUES (1, 'Glitter Drone 3000', 'Spray glitter on an unsuspecting target.', 350, 'drone-1')
END

IF NOT EXISTS (SELECT Id FROM [Toys] WHERE Id=2)
BEGIN
  INSERT INTO [Toys] (Id, Name, Description, Price, ImageId) VALUES (2, 'Gear Shift', 'A truck that transforms into a teddy bear.', 100, 'truck-1')
END

IF NOT EXISTS (SELECT Id FROM [Toys] WHERE Id=3)
BEGIN
  INSERT INTO [Toys] (Id, Name, Description, Price, ImageId) VALUES (3, 'Ball', 'A ball, nothing more.', 20, 'ball-1')
END
