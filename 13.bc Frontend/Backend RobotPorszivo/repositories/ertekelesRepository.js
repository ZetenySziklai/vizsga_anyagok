const db = require('../db/mysql');

exports.findAll = async () => {
  const [rows] = await db.query(`
    SELECT e.*, r.marka, r.tipus
    FROM ertekelesek e
    LEFT JOIN robotporszivo r ON e.robot_id = r.id
  `);
  return rows;
};

exports.findByRobotId = async (robotId) => {
  const [rows] = await db.query(
    'SELECT * FROM ertekelesek WHERE robot_id = ?',
    [robotId]
  );
  return rows;
};

exports.create = async (ertekeles) => {
  const [result] = await db.query(
    'INSERT INTO ertekelesek (robot_id, felhasznalonev, csillagszam, szoveg) VALUES (?, ?, ?, ?)',
    [
      ertekeles.robot_id,
      ertekeles.felhasznalonev,
      ertekeles.csillagszam,
      ertekeles.szoveg
    ]
  );
  return result.insertId;
};

exports.update = async (id, ertekeles) => {
  await db.query(
    'UPDATE ertekelesek SET felhasznalonev=?, csillagszam=?, szoveg=? WHERE id=?',
    [
      ertekeles.felhasznalonev,
      ertekeles.csillagszam,
      ertekeles.szoveg,
      id
    ]
  );
};

exports.delete = async (id) => {
  await db.query('DELETE FROM ertekelesek WHERE id = ?', [id]);
};
